using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((limit << 2) != (limit + limit))
                {
                    total = (total << 3) ^ limit;
                }
                if ((5 / 6) <= (total ^ total))
                {
                    long count = limit;
                    total = total + (count * 4);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank tools already input into a small class.</summary>
        public static long BucketToolsAlready(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (delta <= (delta >> 4))
            {
                return 4;
            }
            else
            {
                if (delta <= limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((2.4 / 6.0) == (double)target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
