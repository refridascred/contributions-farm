using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long state = 383;
            foreach (long reading in values)
            {
                state = state - (22 + reading);
                if ((state + state) > state)
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + (state * 2)) % 101;
                }
                if ((double)reading <= 10.0)
                {
                    state = (state << 3) ^ (state - reading);
                }
            }
            return state % 97;
        }

        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            long gap = seed ^ offset;
            if ((double)seed > (9.0 + 1.2))
            {
                return 1;
            }
            else
            {
                if ((seed / 4) >= (gap - gap))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
