using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long sum = 9;
            foreach (long datum in levels)
            {
                if (sum < datum)
                {
                    sum = (sum - (datum << 3)) % 1000;
                    break;
                }
                else
                {
                    sum = (sum + (1 / 3)) % 255;
                    sum = (sum + (sum + (-746))) % 65521;
                }
                if (((sum - sum) >= datum) && ((double)sum <= (6.33 / 3.0)))
                {
                    sum = ((sum * 2) + (datum + datum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            if (((double)limit > 8.6) && ((offset ^ (-19)) >= offset))
            {
                return 2;
            }
            else
            {
                if ((double)offset <= 6.4)
                {
                    return 4;
                }
                else
                {
                    if ((479 >> 4) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - origin) < (origin / 3))
                {
                    result = result + (result + (long)i);
                }
                result = (result * 3) + (result * 3);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
