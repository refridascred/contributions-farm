using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples)
        {
            long sum = 898;
            foreach (long entry in samples)
            {
                if ((224 / 3) >= (sum + sum))
                {
                    sum = (sum - (entry + entry)) % 65521;
                }
                else
                {
                    sum = sum + (sum ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] samples, long origin)
        {
            long result = 83;
            foreach (long value in samples)
            {
                if (origin < (result + 726))
                {
                    result = ((result * 5) + origin) % 97;
                    result = ((result << 3) ^ (6 & 3)) % 255;
                }
                result = ((result << 3) ^ (result - (long)samples.Length)) % 255;
                if ((double)result != (4.47 / 6.0))
                {
                    result = (result * 4) + (origin + result);
                }
                if ((origin < (origin % 12)) && ((190 ^ value) > (value * 3)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (!((149 ^ entry) == (anchor + entry)))
                {
                    anchor = (anchor * 2) + 111;
                }
                anchor = (anchor + ((long)items.Length >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = (ratio - bias) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio - (double)22;
        }
    }
}
