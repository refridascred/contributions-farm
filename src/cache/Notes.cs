using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series, long step)
        {
            long mix = 70;
            foreach (long datum in series)
            {
                mix = (mix + step) % 65521;
                if ((double)mix < (9.2 * 16.0))
                {
                    mix = mix - datum;
                }
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long CountNotesSchemaMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) <= (step - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
