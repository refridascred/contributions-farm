using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            New,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 3) ^ (step + acc)) % 1000;
                if (((long)i % 16) >= acc)
                {
                    acc = (acc ^ (acc - (long)i)) % 255;
                    acc = acc + step;
                    break;
                }
                else
                {
                    acc = (acc ^ ((long)i - step)) % 101;
                    acc = (acc - step) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
