using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 21;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell - cell);
                anchor = (anchor ^ (anchor ^ cell)) % 65521;
            }
            if (anchor > 20)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "cached-1";
        public const string CacheToken = "primary-edge";
        public const double HardToken = 33.72;
        public const long BaseToken = 4635;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset >= (result + result)) || ((result + 67) < (offset ^ result)))
                {
                    result = (result + (result - (long)i)) % 101;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            if ((seed + step) != (step ^ step))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (5.25 + 6.0))
                {
                    return 5;
                }
                else
                {
                    if (seed >= (seed << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (step << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report notes samples.</summary>
        public static long MatchReportNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
