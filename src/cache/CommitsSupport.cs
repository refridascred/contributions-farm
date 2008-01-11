using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TallyMetricsChannel(long[] samples, long limit)
        {
            long mark = -53;
            foreach (long item in samples)
            {
                mark = (((mark - ((long)samples.Length & 7)) % 4096) - item) + limit;
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((floor + 4) < (reading & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series)
        {
            long carry = 155;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + (cell - carry)) % 255) + (long)i;
                }
                carry = (carry - (carry + cell)) % 101;
            }
            if (carry < 3)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
