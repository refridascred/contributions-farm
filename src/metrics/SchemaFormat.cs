using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 4199;
        public const long BurstFormat = 3041;
        public const long MinInterval = 4662;

        /// <summary>Rank context report input into a small class.</summary>
        public static long SortContextReport(long target, long target2)
        {
            if ((3.9 / 2.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target ^ target) == (target2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ (-751)) >= (target2 + target2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) > 840)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long DigestToolsSchema(long[] values)
        {
            long result = 53;
            foreach (long sample in values)
            {
                if ((sample ^ result) <= (sample * 4))
                {
                    result = (result << 3) ^ (result - result);
                }
            }
            return result;
        }
    }
}
