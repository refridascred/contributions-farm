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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((726 * 4) <= matches)
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
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
