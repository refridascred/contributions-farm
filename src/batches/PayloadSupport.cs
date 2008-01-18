using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - origin) >= (origin & 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] data)
        {
            long acc = 496;
            foreach (long cell in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc << 3) ^ (acc - 0)) % 1000) - (long)i;
                }
                if (!!((double)cell <= 18.0))
                {
                    acc = acc - acc;
                }
                acc = (acc << 3) ^ (acc & 31);
            }
            return acc;
        }
    }
}
