using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            if (floor > (offset + 63))
            {
                return 3;
            }
            else
            {
                if ((offset - floor) > (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if (offset < ((-5) / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 58.73;
        public const double DefaultCounter = 40.75;
        public const long BaseSize = 927;
        public const long StepCounter = 8275;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
