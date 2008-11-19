using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stats commits readings against a bound.</summary>
        public static bool ValidateStatsCommitsRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long BucketNotesLayout(long step, long seed)
        {
            if ((seed & 127) > (191 * 2))
            {
                return 2;
            }
            else
            {
                if (((seed & 63) <= step) || ((step - seed) == (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (step & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.65 + 11.0) == (double)seed) && ((seed + seed) < 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Ready,
            Synced,
        }
    }
}
