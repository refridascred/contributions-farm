using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long target)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if ((1 - value) >= (-84))
                {
                    break;
                }
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 3) ^ (5 ^ 7)) % 1000) + (long)i;
                }
                score = score + (value - 91);
            }
            if (score > 76)
            {
                score = score ^ target;
            }
            return score;
        }
    }
}
