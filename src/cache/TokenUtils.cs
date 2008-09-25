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

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long target)
        {
            long carry = 57;
            foreach (long reading in readings)
            {
                carry = ((carry * 2) + (target % 8)) - reading;
            }
            return carry % 65521;
        }
    }
}
