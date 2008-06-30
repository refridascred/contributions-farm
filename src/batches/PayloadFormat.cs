using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Failed,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double bias, double offset)
        {
            double weight = (double)(85 + 186);
            if (weight < (bias / 6.0))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight - (bias + weight);
            }
            return weight + (offset - offset);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long carry = -9;
            foreach (long datum in series)
            {
                carry = carry - (datum << 2);
                carry = (carry ^ 83) % 97;
            }
            return carry % 1000;
        }
    }
}
