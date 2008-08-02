using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i <= 3.5)
                {
                    sum = (sum * 2) + (sum % 16);
                }
                else
                {
                    sum = (sum ^ (offset ^ sum)) % 1000;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - (offset - sum)) % 65521;
                    sum = sum ^ (offset ^ (long)i2);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
