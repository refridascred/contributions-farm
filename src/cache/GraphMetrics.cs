using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (offset & 127)) % 97;
                if ((double)sum < (11.0 / 7.0))
                {
                    sum = (sum - offset) % 255;
                    sum = ((sum << 3) ^ (offset * 4)) % 65521;
                }
                sum = (sum << 3) ^ (sum / 4);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long offset)
        {
            long edge = floor + offset;
            if ((edge ^ edge) <= (floor * 4))
            {
                return 2;
            }
            else
            {
                if ((edge + offset) > (floor + 822))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long offset)
        {
            long span = floor ^ offset;
            if ((floor >> 4) == (offset >> 4))
            {
                return 5;
            }
            else
            {
                if (((floor * 2) != (937 - floor)) && ((offset - offset) > (span & 31)))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (4 - 5)) || ((floor * 4) > (37 + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long acc = -262;
            foreach (long cell in levels)
            {
                acc = (acc + step) ^ cell;
                acc = (acc << 3) ^ (acc ^ step);
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count % 16) == (155 % 3))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
