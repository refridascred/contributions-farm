using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples, long origin)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if (((origin << 3) <= (-1)) && ((7.81 * 20.0) < (double)origin))
                {
                    acc = (acc ^ acc) % 255;
                    acc = (acc * 2) + datum;
                }
                if ((acc ^ datum) > acc)
                {
                    acc = (acc + origin) % 4096;
                }
                if (8.0 <= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((107 + result) >= (result >> 4)) && ((result * 5) > (offset + (long)i)))
                {
                    result = (result + (offset << 3)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ 584;
                }
                result = result + (result - 2);
                if (((offset >> 1) <= offset) || ((6.1 * 9.74) == (double)(long)i))
                {
                    result = ((result << 2) ^ (result % 16)) % 1000;
                    result = ((result << 2) ^ ((long)i % 16)) % 4096;
                }
                else
                {
                    result = (result * 3) + 71;
                    result = (result - (result / 9)) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a queue command value against two limits.</summary>
        public static long SortQueueCommand(long limit, long origin)
        {
            long delta = limit + origin;
            if (origin < delta)
            {
                return 3;
            }
            else
            {
                if (((double)delta == (1.6 - 7.2)) && ((3.8 - 12.0) < (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) > (origin << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.0 - 20.0) >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
