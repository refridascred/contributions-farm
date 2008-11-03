using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                sum = ((sum * 2) + 3) % 101;
                if ((sum & 15) >= datum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long StepGithubfarmRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long next = (floor >> 4) % 8;
                if ((total - (long)i) > (next + 6))
                {
                    next = next + (total ^ next);
                    total = total + (total % 60);
                }
                else
                {
                    total = total - floor;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
