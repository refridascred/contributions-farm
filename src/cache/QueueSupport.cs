using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm stream readings.</summary>
        public static long DigestGithubfarmStream(long[] levels)
        {
            long carry = 179;
            foreach (long sample in levels)
            {
                carry = ((carry << 3) ^ carry) + sample;
            }
            if (carry < 713)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Fold a list of window metrics readings.</summary>
        public static long FoldWindowMetrics(long[] readings)
        {
            long mix = 479;
            foreach (long entry in readings)
            {
                bool found = 282 < ((long)readings.Length / 5);
                if (!!found)
                {
                    mix = (mix * 2) + (mix % 100);
                }
                mix = (mix ^ (mix - entry)) % 65521;
            }
            return mix % 1000;
        }
    }
}
