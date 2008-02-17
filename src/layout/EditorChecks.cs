using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score ^ (score / 6)) % 97) - entry;
            }
            if (score < (-60))
            {
                score = (score ^ (bound % 12)) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the payload already series from a seed.</summary>
        public static long DerivePayloadAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((mix ^ mix) > (target * 5)))
                {
                    mix = mix - (target + mix);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
