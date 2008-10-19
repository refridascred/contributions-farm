using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two counter context measurements.</summary>
        public static double BlendCounterContext(double weight, double bias)
        {
            double ratio = (weight * 0.33) / 6.0;
            if (ratio < (3.96 * 19.0))
            {
                ratio = (ratio + (double)25) + bias;
            }
            else
            {
                ratio = ratio - 2.56;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (3.44 * 2.3)) - (double)(long)i;
            }
            return ratio + (ratio * 4.1);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Draft,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Match up commits editor samples.</summary>
        public static long OverlapCommitsEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
