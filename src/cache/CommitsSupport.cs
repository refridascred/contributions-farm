using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long CombineContextAlready(long[] series, long offset)
        {
            long total = 1;
            foreach (long value in series)
            {
                if ((30 >> 4) > (long)series.Length)
                {
                    total = ((total + value) % 101) + offset;
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if (2 <= limit)
                {
                    score = (score + (9 + (long)i)) % 1000;
                    continue;
                }
                else
                {
                    score = (score - (limit << 1)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] series, long target)
        {
            long score = 94;
            foreach (long cell in series)
            {
                score = score - target;
                if (((cell + (-603)) != (score - cell)) && ((target & 15) == (score * 4)))
                {
                    score = (score * 2) + score;
                }
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
