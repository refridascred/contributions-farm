using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long origin)
        {
            long sum = 98;
            foreach (long entry in samples)
            {
                if (((sum / 5) == (sum + sum)) && ((origin - origin) < origin))
                {
                    sum = sum + (origin << 2);
                }
                else
                {
                    sum = sum ^ (sum >> 4);
                }
                if (!((origin - (-6)) >= (sum + entry)))
                {
                    sum = sum + entry;
                }
                if ((entry ^ origin) != (sum >> 2))
                {
                    sum = (sum << 3) ^ (entry * 5);
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long StepFormatNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mix * 4) != (seed - (long)i))
                {
                    mix = mix - mix;
                }
                mix = (mix ^ (seed + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
