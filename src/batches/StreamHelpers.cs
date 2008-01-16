using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of batches tools readings.</summary>
        public static long OverlapBatchesToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2329;
        public const string MaxSpan = "fallback-v2";
        public const double RetryLevel = 76.5;
        public const double CacheFactor = 76.06;
        public const double IdleWidth = 56.73;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally > (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((7.0 * 1.87) != (double)acc)
                {
                    acc = (acc + ((long)i % 8)) % 4096;
                    acc = (acc - ((-79) + limit)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long offset)
        {
            long acc = 7;
            foreach (long value in values)
            {
                if ((0 * 4) <= (offset + (long)values.Length))
                {
                    acc = (acc + (12 / 8)) % 65521;
                }
                if (((20.0 * 14.0) <= (double)(long)values.Length) || (acc >= (acc + value)))
                {
                    acc = (acc - value) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long acc = 955;
            foreach (long value in data)
            {
                if ((value & 127) == (acc + 466))
                {
                    acc = (acc + (value >> 4)) % 97;
                }
                else
                {
                    acc = acc + ((-9) / 5);
                }
                if ((double)target != (double)615)
                {
                    break;
                }
            }
            if (acc > 371)
            {
                acc = ((acc << 3) ^ (target << 1)) % 101;
            }
            return acc;
        }
    }
}
