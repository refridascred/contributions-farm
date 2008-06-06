using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long origin)
        {
            long total = 5;
            foreach (long cell in data)
            {
                total = (total + total) % 1000;
                if ((double)cell <= (double)4)
                {
                    continue;
                }
                if ((1.0 * 7.0) != (double)total)
                {
                    total = total ^ (cell * 4);
                }
                else
                {
                    total = total + (origin * 5);
                }
                if ((cell / 4) > cell)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a githubfarm already reading by value.</summary>
        public static long LookupGithubfarmAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((1.08 * 7.0) == (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools cluster readings.</summary>
        public static long ScoreToolsCluster(long[] values, long target)
        {
            long state = 26;
            foreach (long entry in values)
            {
                state = (state - (entry / 7)) % 1000;
                if (225 >= state)
                {
                    state = (state << 3) ^ (entry + target);
                }
                else
                {
                    state = (state ^ (entry ^ target)) % 101;
                }
            }
            if (state < 92)
            {
                state = state - (state & 1);
            }
            return state % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 5) + (long)i;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
