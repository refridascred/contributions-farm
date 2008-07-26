using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double weight = bias2;
            return (weight + (bias2 / 4.0)) + bias;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (reading > result)
                {
                    result = (result - (result ^ 9)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches >> 2) > (matches + (long)data.Length)) && (((item / 5) <= (54 + matches)) || ((matches * 2) < (matches >> 2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
