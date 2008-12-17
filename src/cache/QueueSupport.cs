using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((386 ^ offset) >= offset)
                {
                    score = score + (offset * 5);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.53 + 6.5) <= (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Match up schema order samples.</summary>
        public static long CompareSchemaOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
