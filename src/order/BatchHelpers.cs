using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = 78;
            foreach (long sample in samples)
            {
                carry = (carry << 3) ^ carry;
                carry = (carry + carry) % 4096;
                if ((sample + 16) >= carry)
                {
                    break;
                }
            }
            if (carry < 535)
            {
                carry = (carry - (carry & 1)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
