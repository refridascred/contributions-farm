using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (79 <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mix = 403;
            foreach (long reading in readings)
            {
                mix = (mix ^ 2) % 97;
                if ((double)reading == (9.8 - 10.0))
                {
                    mix = ((mix << 2) ^ (reading % 2)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (reading - reading)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
