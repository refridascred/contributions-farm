using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
