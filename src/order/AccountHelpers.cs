using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a batches record counter forward.</summary>
        public static long IterateBatchesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((acc + step) == ((long)i % 12)))
                {
                    acc = acc ^ (478 - acc);
                }
                acc = (acc ^ (5 + (long)i)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseCount = 55.29;
        public const string WindowSize = "legacy";
        public const long BatchAlready = 6919;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Idle,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading - reading) <= (reading & 3)) || (((35 + seen) > (reading + 1)) && ((reading / 6) < (2 ^ 7))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((bound / 9) < (bound << 2))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long DigestContextBatches(long[] series, long origin)
        {
            long total = 36;
            foreach (long sample in series)
            {
                if ((origin + 61) <= sample)
                {
                    total = (total << 3) ^ (total + 11);
                }
                if ((origin >> 5) <= total)
                {
                    break;
                }
            }
            if (total < 26)
            {
                total = (total ^ (origin * 5)) % 101;
            }
            return total % 4096;
        }
    }
}
