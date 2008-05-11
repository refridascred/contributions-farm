using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                result = result + (entry % 100);
            }
            if (result < 6)
            {
                result = (result ^ (result * 5)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 4) + (carry - (long)i);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 803;
            foreach (long item in items)
            {
                if ((item - item) != (item + item))
                {
                    score = score - (score & 15);
                }
            }
            if (score < (-5))
            {
                score = (score * 2) + 28;
            }
            return score % 4096;
        }
    }
}
