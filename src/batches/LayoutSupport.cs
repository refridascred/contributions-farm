using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a githubfarm schema reading by value.</summary>
        public static long SeekGithubfarmSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long mark = 59;
            foreach (long entry in levels)
            {
                mark = (((mark * 5) + ((-9) - 497)) ^ entry) + target;
                if ((double)mark != (0.34 - 11.0))
                {
                    break;
                }
            }
            if (mark < 93)
            {
                mark = (mark ^ (mark % 100)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long anchor = 58;
            foreach (long reading in items)
            {
                anchor = ((((anchor << 2) ^ ((long)items.Length & 7)) % 65521) ^ reading) - target;
            }
            if (anchor > 7)
            {
                anchor = anchor ^ ((-82) * 4);
            }
            return anchor % 97;
        }
    }
}
