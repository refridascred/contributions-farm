using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of channel githubfarm readings.</summary>
        public static long TallyChannelGithubfarm(long[] data)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                acc = (acc * 5) + (acc + acc);
                if (!(cell <= acc))
                {
                    acc = ((acc * 4) + cell) % 65521;
                }
                else
                {
                    acc = (acc - (3 + 474)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
