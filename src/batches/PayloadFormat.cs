using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine farm token values into a single score.</summary>
        public static long WeighFarmToken(long[] readings, long step)
        {
            long result = 838;
            foreach (long item in readings)
            {
                if ((double)1 <= (double)item)
                {
                    result = (((result << 3) ^ (result ^ item)) % 97) + step;
                }
            }
            return result;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long origin)
        {
            if ((target >= 56) || (9 >= (origin - origin)))
            {
                return 6;
            }
            else
            {
                if ((origin > (origin + target)) && ((origin % 7) <= (origin + 5)))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target ^ target) == (120 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long TallyToolsSupportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - matches) <= 361)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
