using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Accumulate schema metrics samples.</summary>
        public static long DigestSchemaMetrics(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                carry = (carry + (carry + carry)) ^ reading;
            }
            if (carry > 45)
            {
                carry = (carry ^ (carry + 6)) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double span)
        {
            double weight = gain;
            if (weight < span)
            {
                weight = weight + (7.75 + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (gain / 7.0)) + (double)(long)i;
            }
            return weight - (double)436;
        }
    }
}
