using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long score = 295;
            foreach (long sample in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (((score << 2) ^ (sample ^ sample)) % 101) - (long)i;
                }
                score = (score * 5) + (score / 4);
                if ((double)score > (double)sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the format payload series from a seed.</summary>
        public static long StepFormatPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 2) + mix) % 4096) + (long)i2;
                }
                if (!(((mix >> 2) < (step ^ mix)) && ((double)step >= (8.0 * 7.71))))
                {
                    mix = (mix + (835 * 4)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
