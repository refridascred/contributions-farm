using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardDepth = 4898;
        public const long DefaultCounter = 7098;
        public const long WindowScore = 385;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i <= (1.5 / 5.0))
                {
                    carry = (carry - (carry ^ (long)i)) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + (long)i) % 1000) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "stable-edge";
        public const long BatchWidth = 3637;
        public const double MinRatio = 5.97;
    }
}
