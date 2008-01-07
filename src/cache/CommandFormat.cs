using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long AuditSessionReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)value < (7.6 * 3.25)) || (matches <= (value >> 4)))
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((double)mix != (9.0 + 2.0))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            if (mix < (-503))
            {
                mix = mix + 66;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 523;
            foreach (long datum in readings)
            {
                if (!(sum > (sum + sum)))
                {
                    sum = (sum ^ datum) % 97;
                }
            }
            return sum % 1000;
        }
    }
}
