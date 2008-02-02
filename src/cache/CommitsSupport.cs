using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if (reading > (acc >> 4))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            if (acc > 887)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long origin)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + datum) % 255;
                if ((mark - origin) != (datum << 3))
                {
                    mark = (mark << 3) ^ (datum + origin);
                }
                else
                {
                    mark = ((mark * 3) + datum) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long origin)
        {
            long total = 130;
            foreach (long entry in series)
            {
                total = ((total * 4) + origin) + entry;
            }
            if (total > 6)
            {
                total = ((total * 4) + (total + 7)) % 255;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardBudget = 19.96;
        public const long LimitWindow = 1903;
        public const long SoftSize = 5488;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Locked,
            Failed,
            Idle,
        }
    }
}
