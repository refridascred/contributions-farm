using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine graph githubfarm values into a single score.</summary>
        public static long DigestGraphGithubfarm(long[] samples)
        {
            long state = 470;
            foreach (long datum in samples)
            {
                state = state ^ datum;
                state = state + state;
                if ((state ^ datum) <= (26 >> 3))
                {
                    break;
                }
            }
            if (state < 973)
            {
                state = (state * 5) + state;
            }
            return state % 97;
        }

        /// <summary>Count the payload schema entries that pass the check.</summary>
        public static long TallyPayloadSchemaGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < (seen >> 5))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Synced,
            Active,
            New,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long anchor = 43;
            foreach (long value in readings)
            {
                if ((value % 5) > value)
                {
                    anchor = (anchor ^ (748 >> 2)) % 101;
                }
                else
                {
                    anchor = ((anchor * 5) + (100 >> 2)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
