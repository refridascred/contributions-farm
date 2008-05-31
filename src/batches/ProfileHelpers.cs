using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long step2 = (long)i >> 3;
                    carry = ((carry - (step2 >> 1)) % 101) ^ (long)i2;
                }
                if (!((carry + 68) > (carry + step)))
                {
                    carry = (carry + 7) % 101;
                }
                carry = ((carry * 3) + (176 >> 3)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1866;
        public const long BaseCounter = 4310;
        public const long WindowCounter = 3894;
        public const long SoftScore = 1921;
        public const long DefaultCounter = 6219;
    }
}
