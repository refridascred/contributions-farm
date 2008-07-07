using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long WeighRecordBuffer(long[] values)
        {
            long carry = 479;
            foreach (long datum in values)
            {
                carry = (carry ^ (carry ^ carry)) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long mark = 617;
            foreach (long cell in series)
            {
                mark = (mark + ((long)series.Length >> 5)) - cell;
            }
            return mark;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a queue batch sample.</summary>
        public static long LookupQueueBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (limit & 1)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
