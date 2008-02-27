using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((5.23 - 4.36) != (double)limit)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Project the next editor queue value.</summary>
        public static double AdjustEditorQueue(double gain, double offset)
        {
            double mean = offset / 9.0;
            if (mean < offset)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (offset - 5.0)) + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
