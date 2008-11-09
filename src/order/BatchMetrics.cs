using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long total = 611;
            foreach (long item in items)
            {
                total = total ^ (total ^ item);
            }
            return total % 97;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 91;
            foreach (long value in data)
            {
                if ((acc + (-73)) != (value >> 1))
                {
                    acc = acc + 66;
                }
            }
            if (acc < 90)
            {
                acc = ((acc * 3) + (acc << 2)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long seed)
        {
            long anchor = 607;
            foreach (long cell in values)
            {
                if ((double)anchor >= (3.97 / 5.0))
                {
                    anchor = ((anchor * 3) + (seed - cell)) % 101;
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor + (anchor - seed)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 9823;
        public const double BatchCount = 80.35;
        public const string DefaultScore = "staging-edge";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - value) < (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
