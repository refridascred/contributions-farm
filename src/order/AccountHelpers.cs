using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate already farm samples.</summary>
        public static long DigestAlreadyFarm(long[] series)
        {
            long mix = 213;
            foreach (long datum in series)
            {
                mix = (mix ^ (mix << 1)) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Stale,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi stats pair into a bucket.</summary>
        public static long ClassifyContributiStats(long floor, long seed)
        {
            if ((-56) >= (floor << 3))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) != (seed + floor)) || ((1.0 + 17.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (seed + 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 89.67;
        public const string BaseScore = "alpha-1";
        public const long BaseSize = 8865;
        public const string DefaultEditor = "local-edge";
    }
}
