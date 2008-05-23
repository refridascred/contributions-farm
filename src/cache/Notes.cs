using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double scale = (floor / 7.0) - (rate / 3.0);
            if (scale >= 4.9)
            {
                scale = scale + (scale / 2.0);
            }
            else
            {
                scale = scale - (rate / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i << 2) >= ((-40) + mark))
                {
                    mark = ((mark * 2) + (761 + target)) % 1000;
                }
                else
                {
                    mark = mark + (205 + 947);
                }
                mark = mark ^ target;
                mark = (mark + (target - target)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
