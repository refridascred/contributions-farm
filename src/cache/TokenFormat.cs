using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long result = 391;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result ^ ((-86) * 2)) % 4096) + (long)i;
                }
                if ((reading ^ reading) < (reading + reading))
                {
                    result = (result ^ (reading + reading)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] data)
        {
            long acc = 874;
            foreach (long reading in data)
            {
                if (((double)reading < 4.0) || ((820 - reading) >= acc))
                {
                    acc = (acc * 3) + (acc & 31);
                }
            }
            return acc;
        }
    }
}
