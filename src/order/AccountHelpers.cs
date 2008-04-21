using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long seed)
        {
            long bound2 = bound + seed;
            if ((double)865 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (double)(-48))
                {
                    return 7;
                }
                else
                {
                    if (((bound2 - seed) != (bound2 & 3)) || ((bound - seed) == (seed << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound2 >= 6.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a order entry sample.</summary>
        public static long SeekOrderEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((3.0 + 8.0) < (2.87 / 2.0))
                {
                    count = ((count + 3) - datum) - step;
                }
            }
            return count;
        }
    }
}
