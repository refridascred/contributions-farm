using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Locked,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if (3.2 >= (double)item)
                {
                    mix = mix ^ (item ^ mix);
                }
                else
                {
                    mix = mix - item;
                    mix = (mix - item) % 97;
                }
                if (mix <= (6 - 548))
                {
                    mix = mix ^ (mix % 2);
                    break;
                }
                else
                {
                    mix = (mix - item) % 1000;
                    mix = ((mix * 4) + 6) % 65521;
                }
                if (((-354) & 127) != (945 + item))
                {
                    mix = (mix << 2) ^ (mix + item);
                }
            }
            if (mix < 954)
            {
                mix = (mix << 3) ^ (-31);
            }
            return mix;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
