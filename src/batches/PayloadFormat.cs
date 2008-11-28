using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of payload schema readings.</summary>
        public static long MatchPayloadSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 2) ^ (acc * 5)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
