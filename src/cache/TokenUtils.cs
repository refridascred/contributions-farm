using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next buffer contributi value from a seed.</summary>
        public static long StepBufferContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (((sum * 4) + target) % 101) - (long)i2;
                }
                sum = (sum + (sum + target)) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] readings)
        {
            long anchor = 57;
            foreach (long item in readings)
            {
                anchor = anchor ^ anchor;
                if (((7.0 - 1.61) <= (0.4 / 3.0)) && ((anchor - (long)readings.Length) >= (anchor - anchor)))
                {
                    anchor = (anchor * 5) + (167 + item);
                }
                else
                {
                    anchor = ((anchor << 2) ^ 1) % 4096;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - (anchor ^ anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Active,
            Queued,
        }
    }
}
