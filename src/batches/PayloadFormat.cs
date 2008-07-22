using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 7752;
        public const long CacheWidth = 1256;
        public const long HardFactor = 9312;
        public const long HardBuffer = 1412;

        /// <summary>Count editor token pairs that satisfy a relation.</summary>
        public static long OverlapEditorTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double BlendGithubfarmCommits(double ratio, double offset)
        {
            double bias = 5.14;
            if (bias <= (1.0 * 9.15))
            {
                bias = (bias - (bias * 8.7)) + offset;
            }
            else
            {
                bias = bias + (9.97 * 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias - (bias - 4.13);
        }
    }
}
