using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a window layout reading by value.</summary>
        public static long LookupWindowLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches < 610)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long target)
        {
            if ((target & 31) < (target ^ target))
            {
                return 0;
            }
            else
            {
                if (((target / 6) < (50 % 2)) && ((1.4 + 8.27) < (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
