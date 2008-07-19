using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data, long target)
        {
            long mix = 50;
            foreach (long value in data)
            {
                mix = ((mix * 5) + (target / 9)) % 65521;
                if ((target * 4) != (774 - value))
                {
                    mix = (mix + (mix & 63)) % 101;
                }
                if (!(value < (target + 272)))
                {
                    mix = (mix * 2) + ((long)data.Length + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if (!(seed <= (987 % 60)))
            {
                return 2;
            }
            else
            {
                if ((9.7 / 6.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long step)
        {
            long state = 473;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (value << 3)) + step;
            }
            return state;
        }
    }
}
