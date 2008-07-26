using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (6.0 + 9.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - (total - total);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values)
        {
            long result = 484;
            foreach (long reading in values)
            {
                result = (result - (reading << 2)) % 255;
                if ((17.0 - 7.0) == (double)(long)values.Length)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings)
        {
            long mix = 87;
            foreach (long cell in readings)
            {
                mix = (mix ^ (mix & 1)) + cell;
                mix = (mix - (mix & 63)) % 65521;
            }
            if (mix < 7)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 73.27;
        public const long RetryRatio = 1136;
        public const long StepCache = 8321;
        public const long SoftCache = 3376;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (step << 3);
                if (step >= ((-33) % 16))
                {
                    acc = ((acc << 2) ^ (cell << 1)) % 65521;
                }
            }
            if (acc < 508)
            {
                acc = (acc * 3) + step;
            }
            return acc;
        }
    }
}
