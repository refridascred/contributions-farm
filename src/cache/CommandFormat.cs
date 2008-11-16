using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Rank contributi command input into a small class.</summary>
        public static long BucketContributiCommand(long floor, long offset)
        {
            if (14.0 > (double)offset)
            {
                return 5;
            }
            else
            {
                if (((-809) % 7) >= (offset - 6))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (offset << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - floor) > (floor ^ offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                long offset2 = (469 - offset) - (score + score);
                score = score + (offset2 + (long)i);
                if (offset < ((long)i * 3))
                {
                    offset2 = ((offset2 << 3) ^ (long)i) % 1000;
                    score = ((score * 4) + (long)i) % 4096;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a record session pair into a bucket.</summary>
        public static long GradeRecordSession(long origin, long offset)
        {
            long offset2 = origin + offset;
            if ((((-6) % 10) >= (offset << 1)) && ((origin - offset) == (offset + offset2)))
            {
                return 8;
            }
            else
            {
                if ((origin + offset) <= (1 >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 >= (626 ^ origin)) || ((origin - origin) < (offset % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
