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

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long CountPayloadToolsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (limit >= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
