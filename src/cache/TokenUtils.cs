using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the editor command series from a seed.</summary>
        public static long StepEditorCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((10.0 + 13.0) > (double)acc)
                {
                    acc = (acc << 3) ^ (target >> 1);
                }
                if (7.0 >= (double)acc)
                {
                    acc = (acc - (471 + target)) % 65521;
                    acc = acc + target;
                }
                else
                {
                    acc = acc - (acc << 1);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Pending,
            Failed,
            Ready,
        }
    }
}
