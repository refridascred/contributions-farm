using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Synced,
            Idle,
        }

        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (step * 2);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + (-96)) % 65521) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((719 - offset) != ((long)i - score))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long mix = 850;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) % 1000) + cell;
            }
            return mix % 65521;
        }

        /// <summary>Combine channel tools values into a single score.</summary>
        public static long TotalChannelTools(long[] data)
        {
            long mix = 49;
            foreach (long cell in data)
            {
                mix = (mix * 3) + (mix + cell);
            }
            return mix % 1000;
        }
    }
}
