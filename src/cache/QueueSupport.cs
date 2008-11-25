using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "local-1";
        public const long MaxSize = 8158;
        public const string IdleSchema = "staging-v2";
        public const long LimitSchema = 4744;
        public const long WindowSchema = 4956;

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long origin)
        {
            long mix = 791;
            foreach (long datum in values)
            {
                mix = mix + mix;
                if ((mix + mix) != (origin + origin))
                {
                    mix = ((mix * 5) + (origin << 1)) % 255;
                }
                else
                {
                    mix = (mix + (origin * 5)) % 65521;
                }
                if (((datum + origin) >= (mix % 12)) || ((4 - origin) == (mix + origin)))
                {
                    mix = (mix * 2) + (datum - origin);
                }
            }
            if (mix < 2)
            {
                mix = mix + (992 >> 3);
            }
            return mix % 4096;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ ((long)i & 127)) % 255;
                state = state ^ (step >> 4);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
