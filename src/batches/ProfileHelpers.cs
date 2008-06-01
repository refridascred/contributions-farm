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

        /// <summary>Count tools payload pairs that satisfy a relation.</summary>
        public static long MatchToolsPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((carry + target) > (target - target)))
                {
                    carry = carry ^ (long)i;
                    carry = ((carry << 3) ^ (target << 1)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
